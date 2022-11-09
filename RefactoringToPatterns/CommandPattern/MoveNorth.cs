using System.Collections;

namespace RefactoringToPatterns.CommandPattern {
    public class MoveNorth {
        private MarsRover marsRover;

        public MoveNorth(MarsRover marsRover) {
            this.marsRover = marsRover;
        }

        public void Move() {
            marsRover._obstacleFound = ((IList)marsRover._obstacles).Contains($"{marsRover._x}:{marsRover._y - 1}");
            // check if rover reached plateau limit or found an obstacle
            marsRover._y = marsRover._y > 0 && !marsRover._obstacleFound ? marsRover._y -= 1 : marsRover._y;
        }
    }
}