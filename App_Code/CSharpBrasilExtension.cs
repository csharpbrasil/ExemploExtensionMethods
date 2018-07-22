using System;

public static class CSharpBrasilExtension
{
    public static string ToMD5(this string value)
    {
        System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(value);
        byte[] hash = md5.ComputeHash(inputBytes);

        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        for (int i = 0; i < hash.Length; i++)
        {
            sb.Append(hash[i].ToString("X2"));
        }

        return sb.ToString();
    }

    public static decimal CalcularIPI(this decimal value, decimal percentual)
    {
        decimal Total = decimal.Divide(decimal.Multiply(value, percentual), 100);
        return Total;
    }
}