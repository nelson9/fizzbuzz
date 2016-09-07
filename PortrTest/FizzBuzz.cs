using System.Text;

namespace PortrTest
{
    public class FizzBuzz
    {
        private readonly int _fizz;
        private readonly int _buzz;
        private readonly int _start;
        private readonly int _end;
        private readonly int _lucky;
        private int _fizzBuzzCount;
        private int _luckyCount;
        private int _fizzCount;
        private int _buzzCount;

        public FizzBuzz(int fizz, int buzz, int start, int end, int lucky)
        {
            _buzz = buzz;
            _fizz = fizz;
            _start = start;
            _end = end;
            _lucky = lucky;
        }

        public string StartGame()
        {
            var sb = new StringBuilder();

            for (int i = _start; i < _end + 1; i++)
            {
                sb.Append(GetSequence(i));
                sb.Append(" ");
            }

            sb.Append(GetReport());
            return sb.ToString();
        }


        private string GetSequence(int i)
        {
            if (IsLucky(i))
            {
                _luckyCount++;
                return "lucky";
            }
            if (IsBuzz(i) & IsFizz(i))
            {
                _fizzBuzzCount++;
                return "fizzbuzz";
            }
            if (IsBuzz(i))
            {
                _buzzCount++;
                return "buzz";
            }
            if (IsFizz(i))
            {
                _fizzCount++;
                return "fizz";
            }
            return i.ToString();
        }

        private bool IsFizz(int i)
        {
            return (i % _fizz == 0);
        }

        private bool IsBuzz(int i)
        {
            return (i % _buzz == 0);
        }

        private bool IsLucky(int i)
        {
            return i.ToString().Contains(_lucky.ToString());
        }

        private string GetReport()
        {
            var sb = new StringBuilder();

            sb.Append("fizz: " + _fizzCount);
            sb.Append(" buzz: " + _buzzCount);
            sb.Append(" fizzbuzz: " + _fizzBuzzCount);
            sb.Append(" lucky: " + _luckyCount);
            sb.Append(" integer: " + (_end - _luckyCount - _fizzBuzzCount - _fizzCount - _buzzCount));

            return sb.ToString();
        }
    }
}
