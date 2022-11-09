using System.Collections;

namespace RefactoringToPatterns.CommandPattern {
    public class MoveWest : IMove {
        private MarsRover marsRover;

        public MoveWest(MarsRover marsRover) {
            this.marsRover = marsRover;
        }

        public void Move() {
            marsRover._obstacleFound = ((IList)marsRover._obstacles).Contains($"{marsRover._x - 1}:{marsRover._y}");
            // check if rover reached plateau limit or found an obstacle
            marsRover._x = marsRover._x > 0 && !marsRover._obstacleFound ? marsRover._x -= 1 : marsRover._x;
        }
    }
}