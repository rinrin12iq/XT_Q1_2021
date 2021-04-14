using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_3_2_1
{
    class DynamicArray<T> : IEnumerable<T>
    {
        private T[] _myArray;
        private int _length, _capacity;

        public DynamicArray()
        {
            Capacity = 8;
            _myArray = new T[Capacity];
        }

        public DynamicArray(int capacity)
        {
            Capacity = capacity;
            _myArray = new T[Capacity];
        }

        public DynamicArray(IEnumerable<T> someCollection)
            : this(SomeCollectionLength(someCollection))
        {
            var someCollectionEnumerator = someCollection.GetEnumerator();
            for (int i = 0; i < SomeCollectionLength(someCollection); i++)
            {
                someCollectionEnumerator.MoveNext();
                _myArray[i] = someCollectionEnumerator.Current;
            }
        }

        public int Length
        {
            get
            {
                var ArrayEnumerator = _myArray.GetEnumerator();
                _length = 0;
                while (ArrayEnumerator.MoveNext())
                {
                    if (ArrayEnumerator.Current != default)
                    {
                        _length += 1;
                    }
                }
                return _length;
            }
        }

        public int Capacity
        {
            get => _capacity;
            set
            {
                if (_length == 0 || value >= Length)
                {
                    _capacity = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Для Capacity установлено значение, которое меньше Length");
                }
            } 
        }
       

        public T this[int index]
        {
            get
            {
                if (index < Length) 
                {
                    return _myArray[index]; 
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Индекс за пределами массива");
                }
            }
            set 
            {
                if (index < Length)
                {
                    _myArray[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Индекс за пределами массива");
                }
            } 
        }

        public void Add(T elem)
        {
            while (Length >= Capacity)
            {
                Capacity *= 2;
                T[] tempArray = new T[Capacity];
                _myArray.CopyTo(tempArray, 0);
                _myArray = tempArray;
            }

            _myArray[Length] = elem;
        }

        public bool Insert(T item, int index)
        {
            if (index >= Length)
            {
                throw new ArgumentOutOfRangeException("Индекс за пределами массива");
            }

            if (index == Length)
            {
                Add(item);
                return true;
            }
            else
            {
                Add(_myArray[Length - 1]);
                for (int i = Length - 1; i > index; i--)
                {
                    _myArray[i] = _myArray[i - 1];
                }
                _myArray[index] = item;
                return true;
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_myArray[i].Equals(item))
                {
                    _myArray[i] = _myArray[Capacity - 1];
                    for (int j = i; j < Length - 1; j++)
                    {
                        _myArray[j] = _myArray[j + 1];

                    }
                    _myArray[Length - 1] = default;
                    return true;
                }
            }
            return false;
        }

        public void AddRange(IEnumerable<T> someCollection)
        {
            int someCollectionLength = SomeCollectionLength(someCollection);
            if (Length + someCollectionLength > Capacity)
            {
                int newCapacity = (Capacity + someCollectionLength) * 2;

                T[] arr = _myArray;
                _myArray = new T[newCapacity];
                Capacity = newCapacity;
                arr.CopyTo(_myArray, 0);
            }

            int i = Length;
            foreach (var item in someCollection)
            {
                _myArray[i] = item;
                i++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < this.Length; i++)
            {
                yield return _myArray[i];
            }
        }

        private static int SomeCollectionLength(IEnumerable<T> someCollection)
        {
            var someCollectionEnumerator = someCollection.GetEnumerator();
            int CollLength = 0;
            while (someCollectionEnumerator.MoveNext())
            {
                CollLength++;
            }
            return CollLength;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return _myArray.GetEnumerator();
        }
    }
}
