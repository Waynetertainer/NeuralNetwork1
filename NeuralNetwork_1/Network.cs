using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork_1
{
    public class Network
    {
        private int mLayerCount;
        private int[] mLayerSizes;

        public Network(int[] input)
        {
            mLayerCount = input.Length;
            mLayerSizes = input;

        }
    }
}
