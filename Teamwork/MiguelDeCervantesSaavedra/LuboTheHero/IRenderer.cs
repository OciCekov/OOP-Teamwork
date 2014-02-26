using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    interface IRenderer
    {
        void EnqueueForRendering(dynamic obj);

        void RenderAll();

        void ClearQueue();
    }
}
