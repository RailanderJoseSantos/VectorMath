using System;

namespace LibCG
{
    public class Vector2D
    {
        private readonly float x;
        private readonly float y;

        public float GetX()
        {
            return x;
        }
        public float GetY()
        {
            return y;
        }
        public Vector2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2D() { }
        public Vector2D Soma(Vector2D vectorA, Vector2D vectorB)
        {
            float XSoma = vectorA.GetX() + vectorB.GetX();
            float YSoma = vectorA.GetY() + vectorB.GetY();
            Vector2D vectorC = new Vector2D(XSoma, YSoma);
            return vectorC;
        }
        public Vector2D Subtracao(Vector2D vectorA, Vector2D vectorB)
        {
            float XSubtracao = vectorA.GetX() - vectorB.GetX();
            float YSubtracao = vectorA.GetY() - vectorB.GetY();
            Vector2D vectorC = new Vector2D(XSubtracao, YSubtracao);
            return vectorC;
        }

        public Vector2D DivisaoEscalar(Vector2D vector, float valor)
        {
            float XDivisao = (float)vector.GetX() / valor;
            float YDivisao = (float)vector.GetY() / valor;
            Vector2D vectorC = new Vector2D(XDivisao, YDivisao);
            return vectorC;
        }

        public Vector2D Multiplicacao(Vector2D vectorA, Vector2D vectorB)
        {
            float XMultiplicacao = vectorA.GetX() * vectorB.GetX();
            float YMultiplicacao = vectorA.GetY() * vectorB.GetY();
            Vector2D vectorC = new Vector2D(XMultiplicacao, YMultiplicacao);
            return vectorC;
        }

        public Vector2D MultiplicacaoEscalar(Vector2D vector, float valor)
        {
            float XMultiplicacao = vector.GetX() * valor;
            float YMultiplicacao = vector.GetY() * valor;
            Vector2D vectorC = new Vector2D(XMultiplicacao, YMultiplicacao);
            return vectorC;
        }

        public float Dot(Vector2D vectorA, Vector2D vectorB)
        {
            float produtoEscalar = (vectorA.GetX() * vectorB.GetX()) + (vectorA.GetY() * vectorB.GetY());
            return produtoEscalar;
        }

        public float Magnitude(Vector2D vector)
        {
            Double XPow = Math.Pow(Convert.ToDouble(vector.GetX()), 2.0);
            Double YPow = Math.Pow(Convert.ToDouble(vector.GetY()), 2.0);
            Double soma = XPow + YPow;
            float magnitude = (float)Math.Sqrt(soma);
            return magnitude;
        }
        public Vector2D Normalizar(Vector2D vector)
        {
            float magnitude = this.Magnitude(vector);
            float normaX = vector.GetX() / magnitude;
            float normaY = vector.GetY() / magnitude;
            Vector2D vectorNormalizado = new Vector2D(normaX, normaY);
            return vectorNormalizado;
        }
        public Vector2D Projecao(Vector2D vectorB, Vector2D vectorA)
        {
            float magnitude = (float)Math.Pow(Magnitude(vectorA), 2.0);
            float dotAB = Dot(vectorA, vectorB);
            float aux = dotAB / magnitude;
            return MultiplicacaoEscalar(vectorA, aux);
        }

        public bool Igualdade(Vector2D vectorA, Vector2D vectorB)
        {
            float vectorA_Xnormal = Normalizar(vectorA).GetX();
            float vectorA_Ynormal = Normalizar(vectorA).GetY();
            float vectorB_Xnormal = Normalizar(vectorB).GetX();
            float vectorB_Ynormal = Normalizar(vectorB).GetY();

            if (Magnitude(vectorA) == Magnitude(vectorB) && vectorA_Xnormal == vectorB_Xnormal
                && vectorA_Ynormal == vectorB_Ynormal)
                return true;
            else
                return false;
        }
    }
}
