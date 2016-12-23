using System;

namespace Services
{
    public class Validator
    {
        public static string Check(string title, string author, string year, string amount)
        {
            var answer = "";
            var number = 0;
            if (title == "")
            {
                answer += "Warning, title is empty!" + Environment.NewLine;
            }
            if (author == "")
            {
                answer += "Warning, author is empty!" + Environment.NewLine;
            }
            if (!Int32.TryParse(year, out number))
            {
                answer += "Warning, year must be number!" + Environment.NewLine;
            }
            if (Int32.TryParse(year, out number) && number > DateTime.Now.Year)
            {
                answer += "Warning, book from the future!" + Environment.NewLine;
            }
            if (!Int32.TryParse(amount, out number))
            {
                answer += "Warning, number of sheets must be number!" + Environment.NewLine;
            }
            return answer;
        }
    }
}
