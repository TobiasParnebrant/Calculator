using System;
using Xunit;
using Miniräknare_2._0;
using InputOpperator;
using Calculations;


namespace TestProject1
{
    public class CalculatorTest 
    {       
        decimal Value;
        [Theory]
        [InlineData(13, 5, 8)]
        [InlineData(1, -5, 6)]
        [InlineData(70, 20, 50)]
        [InlineData(69, 33, 36)]
        [InlineData(1000, 259, 741)]

        // "expected" är svaret av uträkningen eller det första talet på InlineData raderna. 
        public void AddTwoNumbersShouldEqualTheirEqualTheory(
                decimal expected, decimal FirstToAdd, decimal SecondToAdd)
        {
            
            Value = Calculate.Adding(FirstToAdd, SecondToAdd);

            Assert.Equal(expected, Value); 
        }

        [Theory]
        [InlineData(-3, 5, 8)]
        [InlineData(-11, -5, 6)]
        [InlineData(70, 20, -50)]
        [InlineData(69, 105, 36)]
        [InlineData(0, 259, 741)]
        public void SubTwoNumbersShouldEqualTheirEqualTheory(
                decimal expected, decimal FirstToAdd, decimal SecondToAdd)
        {

            Value = Calculate.Subtract(FirstToAdd, SecondToAdd);

            Assert.Equal(expected, Value);
        }

        [Theory]
        [InlineData(33,100,3)]
        [InlineData(-2,-10,5)]
        [InlineData(4.25,17,4)]
        [InlineData(69, 4761, 69)]
        [InlineData(-6.25,-50,8)]
        public void DivTwoNumbersShouldEqualTheirEqualTheory(
                decimal expected, decimal FirstToAdd, decimal SecondToAdd)
        {

            Value = Calculate.Dividing(FirstToAdd, SecondToAdd);

            Assert.Equal(expected, Value);
        }

        [Theory]
        [InlineData(49,7,7)]
        [InlineData(49,-7,-7)]
        [InlineData(81,9,9)]
        [InlineData(50,25,2)]
        [InlineData(0,0,8)]
        public void MulTwoNumbersShouldEqualTheirEqualTheory(
                decimal expected, decimal FirstToAdd, decimal SecondToAdd)
        {

            Value = Calculate.Multiplication(FirstToAdd, SecondToAdd);

            Assert.Equal(expected, Value);
        }

        [Theory]
        [InlineData(20, 68 )]
        [InlineData(80, 176 )]
        [InlineData(10,50)]
        [InlineData(-12.22 ,10 )]
        [InlineData(-17.7, 0)]
        public void ConvertCelciusOneNumberShouldEqualTheirEqualTheory(
                decimal expected, decimal FirstToAdd)
        {

            Value = Calculate.TOCelsius(FirstToAdd);

            Assert.Equal(expected, Value);
            
            /*decimal e = 0.00001M;
            Assert.True(Math.Abs(expected - Value) < e);
            Assert.True(Math.Abs(expected + Value) > e);*/
        }
        //Testar samma värden för både Celsius ovh Fahrenheit
        [Theory]
        [InlineData(68,20)]
        [InlineData(176,80)]
        [InlineData(50,10)]
        [InlineData(10,-12.22)]
        [InlineData(0,-17.7)]
        public void ConvertFahrenheitOneNumberShouldEqualTheirEqualTheory(
                decimal expected, decimal FirstToAdd)
        {

            Value = Calculate.TOFahrenheit(FirstToAdd);

            Assert.Equal(expected, Value);
        }

        //Testar EasterEggException med både små och stora bokstäver,
        //testar även om värdet är ett nullvärde
        [Fact]
        public void ExceptionTests() 
        {      
            Assert.Throws<OPInputs.EasterEggException>(() => OPInputs.Operator("xyzzy"));
            //Kollar om det blir någon skillnad beroende på om "xyzzy" står i stora eller små bokstäver.
            //Edit har lagt till en "ToLower() nu så testerna har gjorts om lite"
            Assert.Throws<OPInputs.EasterEggException>(() => OPInputs.Operator("XYZZY"));
            Assert.Throws< Exception>(() => OPInputs.Operator(""));
        }        
    }
}

