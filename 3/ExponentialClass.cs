using System;
using System.Data;

namespace Abstarct
{
	public class ExponentialClass: IPair
	{
        
        double firstnumber;
        double difference;
        double number;

        public double FirstNumber
        {
            get
            {
                return firstnumber;
            }

            set
            {
                firstnumber = value;
            }


        }

        public double SequenceNumber
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }

        }

        public double Difference
        {

            get
            {
                return difference;
            }

            set
            {
                difference = value;
            }


        }

        public double GetNNumber()
        {
            double answerNumber = firstnumber * Math.Pow(difference, (number - 1));
            return answerNumber;


        }

        public double GetSumm()
        {
            double answerSumm = (firstnumber * (Math.Pow(difference, number) - 1) 
                )/ (difference - 1);
            return answerSumm;

        }
    }
}

