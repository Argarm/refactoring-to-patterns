using System.Linq;

namespace RefactoringToPatterns.CommandPattern {
    public class MoveSouth {
        private MarsRover marsRover;

        public MoveSouth(MarsRover marsRover) {
            this.marsRover = marsRover;
        }

        public void Move() {
            marsRover._obstacleFound = marsRover._obstacles.Contains($"{marsRover._x}:{marsRover._y + 1}");
            // check if rover reached plateau limit or found an obstacle
            marsRover._y = marsRover._y < 9 && !marsRover._obstacleFound ? marsRover._y += 1 : marsRover._y;
        }
    }
}