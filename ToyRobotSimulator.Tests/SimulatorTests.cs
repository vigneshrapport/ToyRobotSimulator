using ToyRobotSimulator.Core;

namespace ToyRobotSimulator.Tests
{
    public class SimulatorTests
    {
        private Simulator _simulator;

        [SetUp]
        public void SetUp()
        {
            _simulator = new Simulator();
        }

        [TestCase]
        public void SimulatorTests_Report_AfterMoveFromOriginFacingNorth_Returns_0_1_NORTH()
        {
            _simulator.ProcessCommand("PLACE 0,0,NORTH");
            _simulator.ProcessCommand("MOVE");
            string output = _simulator.ProcessCommand("REPORT");
            Assert.That(output, Is.EqualTo("0,1,NORTH"));
        }

        [TestCase]
        public void SimulatorTests_Report_AfterLeftTurnFromOriginFacingNorth_Returns_0_0_WEST()
        {
            _simulator.ProcessCommand("PLACE 0,0,NORTH");
            _simulator.ProcessCommand("LEFT");
            string output = _simulator.ProcessCommand("REPORT");
            Assert.That(output, Is.EqualTo("0,0,WEST"));
        }

        [TestCase]
        public void SimulatorTests_Report_AfterComplexSequence_Returns_3_3_NORTH()
        {
            _simulator.ProcessCommand("PLACE 1,2,EAST");
            _simulator.ProcessCommand("MOVE");
            _simulator.ProcessCommand("MOVE");
            _simulator.ProcessCommand("LEFT");
            _simulator.ProcessCommand("MOVE");
            string output = _simulator.ProcessCommand("REPORT");
            Assert.That(output, Is.EqualTo("3,3,NORTH"));
        }
    }
}