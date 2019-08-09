﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandwrittenDigitRecognitionNN.NN
{
    class HiddenLNeuron : Neuron
    {
        private List<Synapsis> LeftS;
        private List<Synapsis> RightS;
        public float Bias { get; set; }
        public void AddSynapsis(Synapsis s, bool direction)
        {
            if (!direction)
                LeftS.Add(s);
            else
                RightS.Add(s);
        }
        public void UpdateActivation()
        {
            Activation = 0f;
            foreach (Synapsis s in LeftS)
                Activation += s.Left.Activation * s.Weight;

            Activation += Bias;
            Activation = MyMath.Instance.Sigmoid(Activation);
        }
        public void Init()
        {
            Random rn = new Random();
            Bias = (float)rn.NextDouble();
        }
    }
}
