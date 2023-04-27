using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Rowland_Ethan
{
    class FPS : Game
    {

        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }

        public override string Desribe()
        {
            return $"{Title} is afps game rated {Esrb}!";
        }
    }
}
