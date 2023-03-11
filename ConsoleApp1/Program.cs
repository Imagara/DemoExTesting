using System.Text.RegularExpressions;

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        
    }

    public static int MinFromTwoNumbers(int a, int b)
    {
        return (a > b) ? b : a;
    }

    public static bool IsMaxNumber(double firstNum, double secondNum)
    {
        return firstNum > secondNum;
    }

    public static double MetrInSm(double metr)
    {
        return metr * 100;
    }

    public static bool CheckDate(string strDate)
    {
        return DateTime.TryParse(strDate, out _);
    }

    public static bool TryAuth(string login, string password)
    {
        if (login.Trim() == password.Trim())
            return false;
        if (login.Trim().Length < 5)
            return false;
        if(password.Trim().Length < 5)
            return false;
        return true;
    }

    public static bool TryReg(string login, string password, string email, string birthDate)
    {
        if (!Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            return false;
        if (!CheckDate(birthDate))
            return false;
        if (login.Trim() == password.Trim())
            return false;
        if (login.Trim().Length < 5)
            return false;
        if(password.Trim().Length < 5)
            return false;
        if (IsLoginAlreadyTaken(login))
            return false;
        return true;
    }

    private static bool IsLoginAlreadyTaken(string login)
    {
        return false;
    }
}