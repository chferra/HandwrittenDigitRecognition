﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandwrittenDigitRecognitionNN.NN
{
    class InputNeuron : Neuron
    {
        private List<Synapsis> RightS;
        public void AddSynapsis(Synapsis s)
        {
            RightS.Add(s);
        }
    }
}
