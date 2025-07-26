using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class car
    {

        #region attributs
        private int id;

        private string model;
        private double speed;
        #endregion

        #region properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion


        /// if no user defined constructor exists, the compiler will create a Empty Parameterless constructor
        ///public car()
        ///{
        ///} // do nothing

        #region constructor chining
        public car(int id, string model, double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;

        }

        public car(int id) : this(id, "Unknown", 150.0) // constructor chaining
        {

        }

        public car(int id, string model) : this(id, model, 160.0)
        {

        }

        override public string ToString()
        {
            return $"Car Id: {Id} \nModel: {Model} \nSpeed: {Speed}";
        } 
        #endregion



    }
}
