using System;
using System.Collections.Generic;
using System.Text;

namespace LibCG
{
    public class Vector3D
    {
        public float x, y, z;
        public float GetZ() { return z; }
        public float GetY() { return y; }
        public float GetX() { return x; }
        public Vector3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector3D() { }
        public Vector3D Soma(Vector3D vectorA, Vector3D vectorB)
        {
            float XSoma = vectorA.GetX() + vectorB.GetX();
            float YSoma = vectorA.GetY() + vectorB.GetY();
            float ZSoma = vectorA.GetZ() + vectorB.GetZ();
            Vector3D vectorC = new Vector3D(XSoma, YSoma, ZSoma);
            return vectorC;
        }
        public Vector3D Subtracao(Vector3D vectorA, Vector3D vectorB)
        {
            float XSubtracao = vectorA.GetX() - vectorB.GetX();
            float YSubtracao = vectorA.GetY() - vectorB.GetY();
            float ZSubtracao = vectorA.GetZ() - vectorB.GetZ();
            Vector3D vectorC = new Vector3D(XSubtracao, YSubtracao, ZSubtracao);
            return vectorC;
        }

        public Vector3D Multiplicacao(Vector3D vectorA, Vector3D vectorB)
        {
            float XMultiplicacao = vectorA.GetX() * vectorB.GetX();
            float YMultiplicacao = vectorA.GetY() * vectorB.GetY();
            float ZMultiplicacao = vectorA.GetZ() * vectorB.GetZ();
            Vector3D vectorC = new Vector3D(XMultiplicacao, YMultiplicacao, ZMultiplicacao);
            return vectorC;
        }

        public Vector3D MultiplicacaoEscalar(Vector3D vector, float valor)
        {
            float XMultiplicacao = vector.GetX() * valor;
            float YMultiplicacao = vector.GetY() * valor;
            float ZMultiplicacao = vector.GetZ() * valor;
            Vector3D vectorC = new Vector3D(XMultiplicacao, YMultiplicacao, ZMultiplicacao);
            return vectorC;
        }


        public Vector3D DivisaoEscalar(Vector3D vector, float valor)
        {
            float XDivisao = (float)vector.GetX() / valor;
            float YDivisao = (float)vector.GetY() / valor;
            float ZDivisao = (float)vector.GetZ() / valor;
            Vector3D vectorC = new Vector3D(XDivisao, YDivisao, ZDivisao);
            return vectorC;
        }

        public float Dot(Vector3D vectorA, Vector3D vectorB)
        {
            float produtoEscalar = ( (vectorA.GetX() * vectorB.GetX()) ) + ( (vectorA.GetY() * vectorB.GetY() )) + (vectorA.GetZ() * vectorB.GetZ());
            return produtoEscalar;
        }

        public Vector3D Cross(Vector3D vectorA, Vector3D vectorB)
        {
            float crossX = (vectorA.GetY() * vectorB.GetZ()) - (vectorA.GetZ() * vectorB.GetY());
            float crossY = (vectorA.GetZ() * vectorB.GetX()) - (vectorA.GetX() * vectorB.GetZ());
            float crossZ = (vectorA.GetX() * vectorB.GetY()) - (vectorA.GetY() * vectorB.GetX());
            Vector3D vectorCross = new Vector3D(crossX, crossY, crossZ);
            return vectorCross;
        }

        public float Magnitude(Vector3D vector)
        {
            Double XPow = (float)Math.Pow(Convert.ToDouble(vector.GetX()), 2.0);
            Double YPow = (float)Math.Pow(Convert.ToDouble(vector.GetY()), 2.0);
            Double ZPow = (float)Math.Pow(Convert.ToDouble(vector.GetZ()), 2.0);
            Double soma = (float)XPow + YPow + ZPow;
            float magnitude = (float)Math.Sqrt(soma);
            return magnitude;
        }
        public Vector3D Normalizar(Vector3D vector)
        {
            float magnitude = this.Magnitude(vector);
            float normaX = (float)vector.GetX() / magnitude;
            float normaY = (float)vector.GetY() / magnitude;
            float normaZ = (float)vector.GetZ() / magnitude;
            Vector3D vectorNormalizado = new Vector3D(normaX, normaY, normaZ);
            return vectorNormalizado;
        }
        public Vector3D Projecao(Vector3D vectorB, Vector3D vectorA)
        {
            float magnitude = (float)Math.Pow(Magnitude(vectorA), 2.0);
            float dotAB = Dot(vectorA, vectorB);
            float aux = dotAB / magnitude;
            return MultiplicacaoEscalar(vectorA, aux);
        }
        public bool Igualdade(Vector3D vectorA, Vector3D vectorB)
        {
            float vectorA_Xnormal = Normalizar(vectorA).GetX();
            float vectorA_Ynormal = Normalizar(vectorA).GetY();
            float vectorA_Znormal = Normalizar(vectorA).GetZ();
            float vectorB_Xnormal = Normalizar(vectorB).GetX();
            float vectorB_Ynormal = Normalizar(vectorB).GetY();
            float vectorB_Znormal = Normalizar(vectorB).GetZ();
            if (Magnitude(vectorA) == Magnitude(vectorB) && vectorA_Xnormal == vectorB_Xnormal
                && vectorA_Ynormal == vectorB_Ynormal && vectorA_Znormal == vectorB_Znormal)
                return true;
            else
                return false;
        }
    }
}
