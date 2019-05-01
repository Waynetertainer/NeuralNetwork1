using System;
using System.Collections.Generic;

namespace NeuralNetwork_1
{
    public class Network
    {
        private int mLayerCount;
        private int[] mLayerSizes;
        private List<double>[] mBiases;
        private List<List<double>>[] mWeights;
        private Random mRnd = new Random();

        public Network(int[] input)
        {
            mLayerCount = input.Length;
            mLayerSizes = input;
            mBiases = new List<double>[input.Length - 1];
            for (int i = 0; i < input.Length - 1; i++)
            {
                mBiases[i] = (mRnd.GaussianList(input[i + 1]));
            }
            mWeights = new List<List<double>>[input.Length - 1];
            for (int i = 0; i < mWeights.Length; i++)
            {
                mWeights[i] = new List<List<double>>();
                for (int j = 0; j < input[i]; j++)
                {
                    mWeights[i].Add(mRnd.GaussianList(input[i + 1]));
                }
            }
        }



    }
}
