using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieVsNinjaInterface
{
    class IAllInterfaces
    {

        IAllInterfaces() { }


        /// <summary>
        /// 
        /// </summary>
        public interface IDamagable
        {

            void TakeDamage();
            
        }

        /// <summary>
        /// 
        /// </summary>
        public interface IDamager
        {

            void DealDamage();

        }


    }
}
