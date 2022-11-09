using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RefactoringToPatterns.ComposeMethod
{
    public class List
    {

        private readonly bool _readOnly;
        private int _size;
        private object[] _elements;
        private const int SizeToIncrease = 10;

        public List(bool readOnly)
        {
            _readOnly = readOnly;
            _size = 0;
            _elements = new object[_size];
        }

        public void Add(object element) {
            if (_readOnly) return;
            var newSize = _size + 1;

            if(MaxSizeExceeded(newSize)) {
                var newElements = IncreaseElementArraySize();

                InitializeNewElementArray(newElements);

                _elements = newElements;
            }

            AddElementToArray(element);
        }

        private void AddElementToArray(object element) {
            _elements[_size++] = element;
        }

        private object[] IncreaseElementArraySize() {
            return new object[_elements.Length + SizeToIncrease];
        }

        private void InitializeNewElementArray(IList<object> newElements) {
            for (var i = 0; i < _size; i++)
                newElements[i] = _elements[i];
        }

        private bool MaxSizeExceeded(int newSize) {
            return newSize > _elements.Length;
        }

        public object[] Elements()
        {
            return _elements;
        }

    }

}