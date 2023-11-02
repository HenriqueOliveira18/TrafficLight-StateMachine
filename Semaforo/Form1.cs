using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wayne.Lib.StateEngine;
using System.Diagnostics;
using System.ComponentModel.Design;
using Wayne.Lib;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Semaforo
{
    public partial class Form1 : Form, ISemaforo
    {

        ISemaforo semaforo;

        public event EventHandler onBtnClick;
        public event EventHandler onResetBtnClick;
        public event EventHandler onStartBlinkClick;
        public StateMachine stateMachine;
        
        public Wayne.Lib.IServiceContainer ServiceContainer { get; private set; }



        public Form1() { 
       
            InitializeComponent();
        }


        private void onButtonClick(object sender, EventArgs e)
        {
            
            stateMachine.IncomingEvent(new StateEngineEvent(States.SemaforoEvent.buttonClick));
            currentStateLabel.Text = stateMachine.CurrentState.InstanceName;
        }

        private void onResetButtonClick(object sender, EventArgs e)
        {
            stateMachine.IncomingEvent(new StateEngineEvent(States.SemaforoEvent.resetButtonClick));
            currentStateLabel.Text = stateMachine.CurrentState.InstanceName;
        }
        private void onStartBlinkButtonClick(object sender, EventArgs e)
        {
            if (stateMachine.CurrentState.InstanceName == "Semaforo.Blinking.Composite")
            {
                startBlinkBtn.Text = "Start Blinking";
                resetBtn.Visible = true;
                changeStateBtn.Visible = true;
            }
            else
            {
                startBlinkBtn.Text = "Stop Blinking";
                resetBtn.Visible = false;
                changeStateBtn.Visible = false;
                orangeBox.Visible = false;
            }

            
            stateMachine.IncomingEvent(new StateEngineEvent(States.SemaforoEvent.startBlinkEvent));
            currentStateLabel.Text = stateMachine.CurrentState.InstanceName;
        }

        public void turnOnGreen()
        {
            GreenBox.Visible = true;
        }
        public void turnOffGreen()
        {
            GreenBox.Visible = false;
        }
        public void turnOnYellow() { 
            yellowBox.Visible = true;
        }
        public void turnOffYellow()
        {
            yellowBox.Visible= false;
        }
        public void turnOnRed()
        {
            redBox.Visible = true;
        }
        public void turnOffRed()
        {
            redBox.Visible= false;
        }
        public void blink()
        {
           if(!orangeBox.Visible)
            {
                orangeBox.Invoke((Action)delegate {
                    orangeBox.Visible = true;
                });
            }
            else
            {
                orangeBox.Invoke((Action)delegate { 
                    orangeBox.Visible = false; 
                });
            }
        }


        private void changeStateBtn_Click(object sender, EventArgs e)
        {
      
            if (onBtnClick != null)
                onBtnClick(this, EventArgs.Empty);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (onResetBtnClick != null)
                onResetBtnClick(this, EventArgs.Empty);

        }

        private void startBlinkBtn_Click(object sender, EventArgs e)
        {
            if (onStartBlinkClick != null)
                onStartBlinkClick(this, EventArgs.Empty);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "State Machine Started";
            StartStateMachineBtn.Visible = false;
            GreenBox.Visible = false;
            yellowBox.Visible = false;
            redBox.Visible = false;
            orangeBox.Visible = false;

            semaforo = this;
            semaforo.onBtnClick += onButtonClick;
            semaforo.onResetBtnClick += onResetButtonClick;
            semaforo.onStartBlinkClick += onStartBlinkButtonClick;

            //Create statemachine object
            stateMachine = StateMachine.Create("Semaforo", StateMachineType.Synchronous, null, null);

            //Equip it with a state factory.
            //stateMachine.AddStateFactory(new States.SemaforoStateFactory(semaforo));

            ServiceContainer = ServiceContainerFactory.Create();
            ServiceContainer.RegisterService<ISemaforo>(semaforo);

            stateMachine.AddStateFactory(new StateFactory<ISemaforo>(semaforo, ServiceContainer));

            //Configure the state machine.
            States.CONFIGURATION.Config(stateMachine.StateTransitionLookup);
            StartMachine();
        }

        public void StartMachine()
        {
            stateMachine.Initialize();
            stateMachine.Start();
            currentStateLabel.Text = stateMachine.CurrentState.InstanceName;
        }

        private void sqlConnectBtn_Click(object sender, EventArgs e)
        {
           
            string connString = "Data Source=AM2023;Initial Catalog=testDB;Integrated Security=true";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "Select * from testTable";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Person> persons = new List<Person>();
            while (reader.Read())
            {
                persons.Add(new Person()
                {
                    id = reader.GetInt32(0),
                    name = reader.GetString(1),
                    msg = reader.GetString(2)
                });
            }
            string[] rows= new string[persons.Count];
            for(int i=0; i<persons.Count; i++)
            {
                rows[i] = persons[i].id.ToString() + "     " + persons[i].name.ToString() + "\t" + persons[i].msg + "\n";
            }
            string table = string.Concat(rows);
            sql_label.Text = table;
            con.Close();
        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            int id = 0;
            string connString = "Data Source=AM2023;Initial Catalog=testDB;Integrated Security=true";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "SELECT MAX(id) from testTable";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0)+1;
            }
            con.Close();
            if (msgBox.Text.Length == 0 || nameBox.Text.Length == 0) return;

            Person person = new Person() { id=id, msg = msgBox.Text, name = nameBox.Text };

            query = "Insert into testTable(id,name,msg) VALUES (@val1,@val2,@val3)";
            SqlCommand cmd1 = new SqlCommand(query, con);
            cmd1.Parameters.AddWithValue("@val1", person.id);
            cmd1.Parameters.AddWithValue("@val2", person.name);
            cmd1.Parameters.AddWithValue("@val3", person.msg);
            con.Open();
            cmd1.ExecuteNonQuery();

        }

        private void deleteRowBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=AM2023;Initial Catalog=testDB;Integrated Security=true";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "DELETE FROM testTable WHERE  id = (SELECT Max(id) FROM testTable)";
            SqlCommand cmd2 = new SqlCommand(query, con);
            cmd2.ExecuteNonQuery();

        }
    }


    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string msg { get; set; }

    }
}
