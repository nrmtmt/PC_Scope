using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_dso
{
    public class RMS
    {
        public struct threshold
        {
            /// <summary>
            ///Czas trwania pomiarów powyżej ustalonego progu RMS w ms</summary>
            public float durationInMiliSec;
            /// <summary>
            ///Średnia wartość RMS w okresie powyżej zadanego progu</summary>
            public float averageRMS;
            /// <summary>
            ///Maksymalna wartość RMS w okresie powyżej zadanego progu</summary>
            public float maxRMS;
            /// <summary>
            ///Wartości dyskretne wszystkich wartości RMS w okresie powyżej zadanego progu RMS</summary>
            public List<float> RMSvalues;
            /// <summary>
            ///Obliczona liczba próbek na okres</summary>
            public int calculatedSampleRate;
            /// <summary>
            ///Wpisana liczba próbek na okres. Jeśli różna od zera, to na jej podstawie oblicz się wszystkie wartości RMS. W przeciwnym razie liczba próbek na okres jest równa "calculatedSampleRate"</summary>
            public int selectedSampleRate;
        }
        /// <summary>
        /// Zwraca maksymalną wartość RMS w okresie z pomiarów</summary>
        /// <param name="measurements">Dane pomiarowe</param>
        /// <param name="samplesInPeriod">(opcjonalnie)Liczba próbek w okresie. Jeśli 0 - to liczba próbek na okres zostanie policzona automatycznie</param>
        public float calculateMaxRMS(List<float> measurements, int samplesInPeriod = 0)
        {
            return (maxRMSValuesFromSamples(getListOfFullPeriods(measurements, samplesInPeriod)));
        }
        /// <summary>
        /// Zwraca strukturę zawierającą dane wyjściowe powyżej zadanego progu RMS</summary>
        /// <param name="RMSthresholdValue">Wartość progowa</param>
        /// <param name="measurements">Dane pomiarowe</param>
        /// <param name="samplesInPeriod">(opcjonalnie)Liczba próbek w okresie. Jeśli 0 - to liczba próbek na okres zostanie policzona automatycznie</param>
        public threshold getRMSValuesOverThreshold(float RMSthresholdValue, List<float> measurements, int samplesInPeriod = 0)
        {
            threshold currTh = new threshold();
            List<float> RMSvalues = new List<float>();
            foreach (List<float> period in getListOfFullPeriods(measurements, samplesInPeriod))
            {
                RMSvalues.Add(calculateRMS(period));
            }

            List<float> getPeriodsOverTherhold = (List<float>)RMSvalues.Where(item => item > RMSthresholdValue).ToList();
            if (getPeriodsOverTherhold.Count > 0)
            {
                currTh.durationInMiliSec = 20 * getPeriodsOverTherhold.Count();
                currTh.averageRMS = getPeriodsOverTherhold.Select(x => x).Average();
                currTh.maxRMS = getPeriodsOverTherhold.Select(x => x).Max();
                currTh.RMSvalues = getPeriodsOverTherhold;
            }
            else
            {
                currTh.durationInMiliSec = 0;
                currTh.averageRMS = 0;
                currTh.maxRMS = calculateMaxRMS(measurements);
            }
            currTh.selectedSampleRate = samplesInPeriod;
            currTh.calculatedSampleRate = getSamplesPerPeriod(measurements);
            return currTh;
        }
        /// <summary>
        /// Zwraca listę pomiarów podzielonych na okresy</summary>
        /// <param name="measurements">Dane pomiarowe</param>
        /// <param name="samplesInPeriod">(opcjonalnie)Liczba próbek w okresie. Jeśli 0 - to liczba próbek na okres zostanie policzona automatycznie</param>
        public List<List<float>> getListOfFullPeriods(List<float> measurements, int samplesInPeriod = 0)
        {
            List<float> singlePeriod = new List<float>();
            List<List<float>> tempListOfPeriods = new List<List<float>>();
            List<List<float>> listOfPeriods = new List<List<float>>();
            int samplesPerPeriod = samplesInPeriod;
            if (samplesInPeriod == 0)
            {
                samplesPerPeriod = getSamplesPerPeriod(measurements);
            }

            for (int index = 0; index < measurements.Count; index = index + samplesPerPeriod)
            {
                for (int sample = 0; sample < samplesPerPeriod; sample++)
                {
                    if (sample + index < measurements.Count) { singlePeriod.Add(measurements[sample + index]); }
                }
                listOfPeriods.Add(singlePeriod);
                singlePeriod = new List<float>();
            }

            foreach (List<float> curPeriod in tempListOfPeriods)
            {
                if (curPeriod.Count == samplesPerPeriod)
                {
                    listOfPeriods.Add(curPeriod);
                }
            }
            return listOfPeriods;
        }


        //metody prywatne
        private int getSamplesPerPeriod(List<float> measurements)
        {
            float previous = 0;
            float current = 0;
            int samplesPerPeriod = 0;

            List<List<float>> tempListOfPeriods = new List<List<float>>();
            List<float> singlePeriod = new List<float>();

            //float maxValue = measurements.Select(x => x).Max();
            //float minValue = measurements.Select(x => x).Min();

            foreach (float measure in measurements)
            {
                current = measure;
                samplesPerPeriod++;
                singlePeriod.Add(measure);

                if (current <= 0 && previous > 0) //new period - by 0
                {
                    tempListOfPeriods.Add(singlePeriod);
                    singlePeriod = new List<float>();
                    samplesPerPeriod = 0;
                }
                previous = measure;
            }
            samplesPerPeriod = tempListOfPeriods.GroupBy(x => x.Count)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .First();
            return samplesPerPeriod;
        }

        private float maxRMSValuesFromSamples(List<List<float>> periods)
        {
            try
            {
                List<float> rmsValues = new List<float>();
                foreach (List<float> period in periods)
                {
                    rmsValues.Add(calculateRMS(period));
                }
                return rmsValues.Select(x => x).Max();
            }catch (Exception)
            {
                return 0;
            }
        }

        private float calculateRMS(List<float> period)
        {
            float averagePower = 0;
            float RMSpower = 0;
            int samplesPerPeriod = period.Count;
            foreach (float sample in period)
            {
                averagePower += (float)Math.Pow(sample, 2);
            }
            averagePower = averagePower / samplesPerPeriod;
            RMSpower = (float)Math.Sqrt(averagePower);
            return RMSpower;
        }
    }
}
