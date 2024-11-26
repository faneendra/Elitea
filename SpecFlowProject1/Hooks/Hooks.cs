using TechTalk.SpecFlow;
using Utilities;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly DriverContext driverContext;

        public Hooks(DriverContext context)
        {
            driverContext = context;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driverContext.InitializeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driverContext.CloseDriver();
        }
    }
}