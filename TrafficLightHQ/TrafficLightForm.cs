using System;
using System.Windows.Forms;
using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Visualizer;
using Wayne.Lib.StateEngine.Analyzer;
using Wayne.Lib;
using Wayne.Lib.Log;
using System.IO;
using System.Reflection;


namespace TrafficLight
{
    public partial class TrafficLightForm : Form, ITrafficLight, IIdentifiableEntity
    {

        #region Fields
        ITrafficLight trafficLight;

        public event EventHandler onStateClick;
        public event EventHandler onResetClick;
        public event EventHandler onBlinkClick;
        public StateMachine stateMachine;
        private DebugLogger logger;
        private StateMachineVisualizer stateMachineVisualizer;

        #endregion

        #region Construtors

        public IServiceContainer ServiceContainer { get; private set; }

        public TrafficLightForm()
        {
            InitializeComponent();

            // Directions for the log files
            Uri fileUri = new Uri(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase), "LogConfig.xml"));
            Logger.SetConfigFile(fileUri.LocalPath);

            logger = new DebugLogger(this, true);
        }

        #endregion 

        #region Methods for Lights
        public void blink()
        {
            if (!pbYellow.Visible)
            {
                pbYellow.Invoke((Action)delegate
                {
                    pbYellow.Visible = true;
                });
            }
            else
            {
                pbYellow.Invoke((Action)delegate
                {
                    pbYellow.Visible = false;
                });

            }
        }

        public void turnOffGreen()
        {
            pbGreen.Visible = false;
        }

        public void turnOffRed()
        {
            pbRed.Visible = false;
        }

        public void turnOffYellow()
        {
            pbYellow.Visible = false;
        }

        public void turnOnGreen()
        {
            pbGreen.Visible = true;
        }

        public void turnOnRed()
        {
            pbRed.Visible = true;
        }

        public void turnOnYellow()
        {
            pbYellow.Visible = true;
        }

        #endregion

        #region On Loading Form
        private void TrafficLightForm_Load(object sender, EventArgs e)
        {
            lCurrentState.Text = "State Machine Started";
            pbGreen.Visible = false;
            pbYellow.Visible = false;
            pbRed.Visible = false;

            trafficLight = this;
            trafficLight.onStateClick += onButtonClick;
            trafficLight.onResetClick += onResetButtonClick;
            trafficLight.onBlinkClick += onStartBlinkButtonClick;

            StartMachine();
        }

        #endregion

        #region State Machine

        private void StartMachine()
        {
            // Create State Machine Object
            stateMachine = StateMachine.Create("Traffic Light", StateMachineType.Synchronous, logger, "StateMachine");

            // Connect the State Factory
            ServiceContainer = ServiceContainerFactory.Create();
            ServiceContainer.RegisterService<ITrafficLight>(trafficLight);

            stateMachine.AddStateFactory(new StateFactory<ITrafficLight>(trafficLight, ServiceContainer));

            // Configure the State Machine
            States.Configuration.Config(stateMachine.StateTransitionLookup);

            stateMachine.Initialize();
            stateMachine.Start();
            lCurrentState.Text = stateMachine.CurrentState.InstanceName;

            StateMachineVisualizer();
        }

        #endregion

        #region State Machine Visualizer

        private void StateMachineVisualizer()
        {
            // Create the StateMachineVisualizer aid if not already created (must be created after the statemachine has started).
            if (stateMachineVisualizer == null)
                stateMachineVisualizer = new StateMachineVisualizer(stateMachine); // Please notice that this class is disposed in the form's Dispose-method!

            // Analyze the statemachine.
            GenerateDocumentationXmlOptions generateDocumentationXmlOptions = new GenerateDocumentationXmlOptions();
            generateDocumentationXmlOptions.IncludeIssues = true;
            generateDocumentationXmlOptions.ImagePath = @"C:\Temp\"; // Where to store images
            generateDocumentationXmlOptions.ImageAnalyzer = stateMachineVisualizer;
            generateDocumentationXmlOptions.ImageScale = 1.0f / stateMachineVisualizer.AppearanceManager.PrinterScaling;

            AnalyzedStateMachine analyzedStateMachine = new AnalyzedStateMachine(stateMachine);
            analyzedStateMachine.AbbreviatorDictionary.Add("TrafficLight.States.TransitionEnum", "TransitionEnum");
            analyzedStateMachine.AbbreviatorDictionary.Add("TrafficLight.States.EventsEnum", "EventsEnum");
            analyzedStateMachine.GenerateDocumentationXml(@"C:\Temp\TrafficSignAnalyze.xml", generateDocumentationXmlOptions);

            // Start the visualizer.
            stateMachineVisualizer.Show();
        }

        #endregion

        #region Methods of Events

        private void bState_Click(object sender, EventArgs e)
        {
            if (onStateClick != null)
                onStateClick(this, EventArgs.Empty);
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            if (onResetClick != null)
                onResetClick(this, EventArgs.Empty);
        }

        private void bBlinking_Click(object sender, EventArgs e)
        {
            if (onBlinkClick != null)
                onBlinkClick(this, EventArgs.Empty);
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            logger.Add("Test: Log onButtonClick");
            stateMachine.IncomingEvent(new StateEngineEvent(States.EventsEnum.StateClick));
            lCurrentState.Text = stateMachine.CurrentState.InstanceName;
        }

        private void onResetButtonClick(object sender, EventArgs e)
        {
            logger.Add("Test: Log onResetButtonClick");
            stateMachine.IncomingEvent(new StateEngineEvent(States.EventsEnum.ResetClick));
            lCurrentState.Text = stateMachine.CurrentState.InstanceName;
        }
        private void onStartBlinkButtonClick(object sender, EventArgs e)
        {
            logger.Add("Test: Log onStartBlinkButtonClick");

            // Enter when is leaving Composite State
            if (stateMachine.CurrentState.InstanceName == "TrafficLight.Blinking.Composite")
            {
                bBlinking.Text = "Start Blinking";
                bReset.Visible = true;
                bState.Visible = true;
            }
            // Enter when is entering Composite State
            else
            {
                bBlinking.Text = "Stop Blinking";
                bReset.Visible = false;
                bState.Visible = false;
                pbYellow.Visible = false;
            }

            stateMachine.IncomingEvent(new StateEngineEvent(States.EventsEnum.BlinkClick));
            lCurrentState.Text = stateMachine.CurrentState.InstanceName;
        }
        private void TrafficLightForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            logger.Dispose();
        }

        #endregion

        #region IIdentifiableEntity

        public int Id { get { return IdentifiableEntity.NoId; } }

        public string EntityType { get { return "TrafficLight"; } }

        public string EntitySubType { get { return String.Empty; } }

        public IIdentifiableEntity ParentEntity { get { return null; } }

        #endregion

    }
}