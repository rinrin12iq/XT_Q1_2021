namespace Task_2_1_1
{
    public class MyString
    {
        private char[] _charArray;

        public MyString()
        {
            _charArray = new char[16];
        }

        public MyString(int i)
        {
            _charArray = new char[i];
        }

        public MyString(char[] massofchar)
        {
            massofchar.CopyTo(_charArray, 0);
        }

        public MyString(string str)
        {
            _charArray = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                _charArray[i] = str[i];
            }
        }

        public int Length => _charArray.Length;

        public char this[int i]
        {
            get => _charArray[i];
            set => _charArray[i] = value;
        }

        public static MyString ToMyString(char[] MassOfChar) => new MyString(MassOfChar);
        public static MyString ToMyString(string str) => new MyString(str);
        public static char[] ToChar(MyString mystr) => mystr._charArray;

        public static bool MyEquals(MyString mystr1, MyString mystr2)
        {
            if (mystr1.Length != mystr2.Length)
                return false;

            for (int i = 0; i < mystr1.Length; i++)
            {
                if (mystr1._charArray[i] != mystr2._charArray[i])
                    return false;
            }

            return true;
        }

        public int Search(char NeededChar)
        {
            for (int i = 0; i < _charArray.Length; i++)
            {
                if (_charArray[i] == NeededChar)
                    return i + 1;
            }
            return -1;
        }

        public override string ToString()
        {
            return new string(_charArray);
        }

        public static MyString operator +(MyString mystr1, MyString mystr2)
        {
            int temp = mystr1.Length + mystr2.Length;
            MyString NewMystr = new MyString(temp);
            for (int i = 0; i < mystr1.Length; i++)
            {
                NewMystr._charArray[i] = mystr1._charArray[i];
            }
            for (int j = 0; j < mystr2.Length; j++)
            {
                NewMystr._charArray[mystr1.Length + j] = mystr2._charArray[j];
            }
            return NewMystr;
        }


        public static bool operator ==(MyString mystr1, MyString mystr2)
        {
            return MyString.MyEquals(mystr1, mystr2);
        }

        public static bool operator !=(MyString mystr1, MyString mystr2)
        {
            return !MyString.MyEquals(mystr1, mystr2);
        }
    }
}
