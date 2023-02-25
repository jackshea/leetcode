namespace LeetCode.Problems.Medium;

/// 剑指 Offer 20. 表示数值的字符串
/// https://leetcode-cn.com/problems/biao-shi-shu-zhi-de-zi-fu-chuan-lcof/
public class Offer20
{
    public bool IsNumber(string s)
    {
        s = s.Trim();
        IState curState = new InitialState();
        foreach (var c in s)
        {
            var charType = ToCharType(c);
            curState = curState.Transfer(charType);
            if (curState == States.IllegalState) return false;
        }

        return curState.IsNumber();
    }

    private CharType ToCharType(char c)
    {
        if (c >= '0' && c <= '9')
            return CharType.Number;
        if (c == 'E' || c == 'e')
            return CharType.Exp;
        if (c == '.')
            return CharType.Point;
        if (c == '+' || c == '-')
            return CharType.Sign;
        return CharType.Illegal;
    }
}

public interface IState
{
    IState Transfer(CharType charType);
    bool IsNumber();
}

public class States
{
    public static InitialState InitialState = new();
    public static IllegalState IllegalState = new();
    public static IntSignState IntSignState = new();
    public static IntegerState IntegerState = new();
    public static PointState PointState = new();
    public static PointWithoutIntState PointWithoutIntState = new();
    public static FractionState FractionState = new();
    public static ExpState ExpState = new();
    public static ExpSignState ExpSignState = new();
    public static ExpNumberState ExpNumberState = new();
}

/// 初始状态
public class InitialState : IState
{
    public IState Transfer(CharType charType)
    {
        switch (charType)
        {
            case CharType.Number:
                return States.IntegerState;
            case CharType.Point:
                return States.PointWithoutIntState;
            case CharType.Sign:
                return States.IntSignState;
        }

        return States.IllegalState;
    }

    public bool IsNumber()
    {
        return false;
    }
}

/// 非法状态
public class IllegalState : IState
{
    public IState Transfer(CharType charType)
    {
        return States.IllegalState;
    }

    public bool IsNumber()
    {
        return false;
    }
}

/// 整数符号
public class IntSignState : IState
{
    public IState Transfer(CharType charType)
    {
        switch (charType)
        {
            case CharType.Number:
                return States.IntegerState;
            case CharType.Point:
                return States.PointWithoutIntState;
        }

        return States.IllegalState;
    }

    public bool IsNumber()
    {
        return false;
    }
}

/// 整数部分
public class IntegerState : IState
{
    public IState Transfer(CharType charType)
    {
        switch (charType)
        {
            case CharType.Number:
                return States.IntegerState;
            case CharType.Exp:
                return States.ExpState;
            case CharType.Point:
                return States.PointState;
        }

        return States.IllegalState;
    }

    public bool IsNumber()
    {
        return true;
    }
}

/// 有整数部分的小数点
public class PointState : IState
{
    public IState Transfer(CharType charType)
    {
        switch (charType)
        {
            case CharType.Number:
                return States.FractionState;
            case CharType.Exp:
                return States.ExpState;
        }

        return States.IllegalState;
    }

    public bool IsNumber()
    {
        return true;
    }
}

/// 无整数部分的小数点
public class PointWithoutIntState : IState
{
    public IState Transfer(CharType charType)
    {
        switch (charType)
        {
            case CharType.Number:
                return States.FractionState;
        }

        return States.IllegalState;
    }

    public bool IsNumber()
    {
        return false;
    }
}

/// 小数部分
public class FractionState : IState
{
    public IState Transfer(CharType charType)
    {
        switch (charType)
        {
            case CharType.Number:
                return States.FractionState;
            case CharType.Exp:
                return States.ExpState;
        }

        return States.IllegalState;
    }

    public bool IsNumber()
    {
        return true;
    }
}

/// 指数E
public class ExpState : IState
{
    public IState Transfer(CharType charType)
    {
        switch (charType)
        {
            case CharType.Number:
                return States.ExpNumberState;
            case CharType.Sign:
                return States.ExpSignState;
        }

        return States.IllegalState;
    }

    public bool IsNumber()
    {
        return false;
    }
}

/// 指数部分的正负号
public class ExpSignState : IState
{
    public IState Transfer(CharType charType)
    {
        switch (charType)
        {
            case CharType.Number:
                return States.ExpNumberState;
        }

        return States.IllegalState;
    }

    public bool IsNumber()
    {
        return false;
    }
}

/// 指数数字部分
public class ExpNumberState : IState
{
    public IState Transfer(CharType charType)
    {
        switch (charType)
        {
            case CharType.Number:
                return States.ExpNumberState;
        }

        return States.IllegalState;
    }

    public bool IsNumber()
    {
        return true;
    }
}

public enum CharType
{
    Number,
    Exp,
    Point,
    Sign,
    Illegal
}