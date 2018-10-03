using System;
using System.Collections.Generic;
using System.Text;


namespace KPSF.Services
{
    /// <summary>
    /// Robust, 3-parameter, proportional-integral-derivative controller
    /// https://brettbeauregard.com/blog/2011/04/improving-the-beginners-pid-introduction/
    /// </summary>
    public class PID
    {
        private DateTime lastUpdate;

        public double Kp { get; private set; }

        public double Ki { get; private set; }

        public double Kd { get; private set; }

        public double OutputMin { get; private set; }

        public double OutputMax { get; private set; }

        double lastInput;
        double integralTerm; 

        public PID(double kp = 1, double ki = 0, double kd = 0, double outputMin = -1, double outputMax = 1)
        {
            lastUpdate = DateTime.Now;
            Reset(kp, ki, kd, outputMin, outputMax);
        }

        public void Reset(double kp = 1, double ki = 0, double kd = 0, double outputMin = -1, double outputMax = 1)
        {
            integralTerm = 0;
            lastInput = 0;
            SetParameters(kp, ki, kd, outputMin, outputMax);
        }

        public void SetParameters(double kp, double ki, double kd, double outputMin = -1, double outputMax = 1)
        {
            Kp = kp;
            Ki = ki;
            Kd = kd;
            OutputMin = outputMin;
            OutputMax = outputMax;
            integralTerm = Clamp(integralTerm, OutputMin, OutputMax);
        }

        public double Update(double setpoint, double input)
        {
            double deltaTime = (DateTime.Now - lastUpdate).TotalSeconds;
            lastUpdate = DateTime.Now;

            var error = setpoint - input;
            integralTerm += Ki * error * deltaTime;
            integralTerm = Clamp(integralTerm, OutputMin, OutputMax);
            var derivativeInput = (input - lastInput) / deltaTime;
            var output = Kp * error + integralTerm - Kd * derivativeInput;
            output = Clamp(output, OutputMin, OutputMax);
            lastInput = input;
            return output;
        }

        public void ClearIntegralTerm()
        {
            integralTerm = 0;
        }

        public double Clamp(double value, double min, double max)
        {
            if (value.CompareTo(min) < 0)
                return min;
            if (value.CompareTo(max) > 0)
                return max;
            return value;
        }
    }
}
