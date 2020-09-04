using simple_code.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleCode.Service
{
    public class MainController
    {
        private SimpleServices simples = new SimpleServices();

        private AdvanceServices advances = new AdvanceServices();

        public SimpleServices GetSimples() {
            return simples;
        }

        public AdvanceServices GetAdvances() {
            return advances;
        }
    }
}
