using System.Linq;

namespace RefactoringToPatterns.CommandPattern {
    public class MoveEast {
        private MarsRover marsRover;

        public MoveEast(MarsRover marsRover) {
            this.marsRover = marsRover;
        }

        public void Move() {
            marsRover._obstacleFound = marsRover._obstacles.Contains($"{marsRover._x + 1}:{marsRover._y}");
            // check if rover reached plateau limit or found an obstacle
            marsRover._x = marsRover._x < 9 && !marsRover._obstacleFound ? marsRover._x += 1 : marsRover._x;
        }
    }
}