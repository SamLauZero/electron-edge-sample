﻿namespace HelloWorld
{
    using System.Threading.Tasks;
    public class Startup
    {
        public async Task<object> Invoke(object input)
        {
            Helper h = new Helper();

            return Helper.GetHelp();
        }
    }
}
