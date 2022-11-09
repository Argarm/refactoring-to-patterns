using System;
using System.Collections.Generic;

namespace RefactoringToPatterns.CommandPattern {
    public class MovementFactory {
        private Dictionary<string, Func<IMove>> movementList;

        public MovementFactory(MarsRover marsRover) {
            movementList = new Dictionary<string, Func<IMove>> {
                { "N", () => new MoveNorth(marsRover) },
                { "S", () => new MoveSouth(marsRover) },
                { "E", () => new MoveEast(marsRover) },
                { "W", () => new MoveWest(marsRover) }

            };
        }

        public IMove Create(string direction)
        {
            return movementList[direction].Invoke();
        }
    }
}