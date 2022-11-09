using System;
using System.Collections.Generic;

namespace RefactoringToPatterns.CommandPattern {
    public class MovementFactory {
        private Dictionary<char, Func<IMove>> movementList;

        public MovementFactory(MarsRover marsRover) {
            movementList = new Dictionary<char, Func<IMove>> {
                { 'N', () => new MoveNorth(marsRover) },
                { 'S', () => new MoveSouth(marsRover) },
                { 'E', () => new MoveEast(marsRover) },
                { 'W', () => new MoveWest(marsRover) }

            };
        }

        public IMove Create(char direction)
        {
            return movementList[direction].Invoke();
        }
    }
}