using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Text_Adventure_Winforms
{
    public abstract class Manager<T> : IManager where T : class
    {
        private static T m_Instance;

        //---------------------------------------------------------------------------

        public string Name { get { return GetType().Name; } }

        //---------------------------------------------------------------------------

        protected Manager()
        {
            Init();
        }

        //---------------------------------------------------------------------------

        public static T Get() { return m_Instance ?? (m_Instance = CreateInstance()); }

        //---------------------------------------------------------------------------

        private static T CreateInstance()
        {
            BindingFlags flags = (BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            ConstructorInfo ctor = typeof(T).GetConstructor(flags, null, Type.EmptyTypes, null);
            if (ctor == null) throw new Exception(string.Format("Type {0} does not have a valid constructor.", typeof(T).ToString()));
            return (T)ctor.Invoke(null);
        }

        //---------------------------------------------------------------------------

        protected virtual void Init() { }
    }
}
