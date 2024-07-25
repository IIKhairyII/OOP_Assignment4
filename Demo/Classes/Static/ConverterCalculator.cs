namespace Demo.Classes.Static
{
    public static class ConverterCalculator
    {
        private static readonly double _pi;
        private static readonly double _currencyConverter;
        private static readonly double _lengthConverter;
        static ConverterCalculator()
        {
            _pi = Math.PI;
            _currencyConverter = 45;
            _lengthConverter = 10;
        }
        public static double CalculateCircleArea(double radius) => _pi * radius * radius;
        public static double ConvertFromUsdToEgp(double amountUsd) => amountUsd * _currencyConverter;
        public static double ConvertFromCmToMm(double Cm) => Cm * _lengthConverter;
    }
}
