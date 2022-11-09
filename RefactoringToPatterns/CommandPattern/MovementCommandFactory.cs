using System;
using System.Collections.Generic;

namespace RefactoringToPatterns.CommandPattern {
    public class MovementCommandFactory {
        private Dictionary<char, Func<IMove>> movementList;

        public MovementCommandFactory(MarsRover marsRover) {
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