using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDB
{
    public partial class FormDeleteMe : Form
    {
        private CarBusLogic cBL = new CarBusLogic();
        private GolfBallBusLogic gbBL = new GolfBallBusLogic();

        public FormDeleteMe()
        {
            InitializeComponent();



            userControlEntityEditor1.AddListBoxItem(new EntityCars("Escape"));
            userControlEntityEditor1.AddListBoxItem(new EntityCars("Explorer"));
            userControlEntityEditor1.AddListBoxItem(new EntityCars("F150"));
            userControlEntityEditor1.AddListBoxItem(new EntityCars("Miata"));

            userControlEntityEditor1.setBusinessLogic(cBL);

            userControlEntityEditor2.AddListBoxItem(new EntityGolfBalls("Titleist"));
            userControlEntityEditor2.AddListBoxItem(new EntityGolfBalls("Srixon"));
            userControlEntityEditor2.AddListBoxItem(new EntityGolfBalls("Calloway"));
            userControlEntityEditor2.AddListBoxItem(new EntityGolfBalls("TopFlite"));

            userControlEntityEditor2.setBusinessLogic(gbBL);
        
        }


    }

    public class EntityCars
    {
        public String carName;

        public EntityCars (String name)
        {
            carName = name;
        }

        private EntityCars()
        { }


        public override string  ToString()
        {
 	        return carName;
        }
    }


    public class EntityGolfBalls
    {
        public String ballName;

        public EntityGolfBalls (String name)
        {
            ballName = name;
        }

        private EntityGolfBalls()
        { }


        public override string ToString()
        {
 	        return ballName;
        }
    }


    public class CarBusLogic: iEntityEditorBusinesssLogic
    {
        public object Copy(object obj)
        {
            EntityCars e = (EntityCars)obj;
            EntityCars carNew = new EntityCars(e.ToString() + " new");
            // TODO Add obj to DB
            return carNew;
        }

        public void Modify(object obj)
        {
            EntityCars e = (EntityCars)obj;
            e.carName = e.carName + "MOD";
        }

        public void Delete(object obj)
        {
            // TODO Remove obj from DB
        }
        
        public object Create()
        {
            // TODO Add obj to DB
            return new Int32();
        }

        public void Links()
        {}
        public void Import()
        { }
        public void Preview(object obj)
        { }
        public void HelpModify(object obj)
        { }
        public void HelpPreview(object obj)
        { }

        public void ChangeDisplayName(int name)
        { }


    }

    public class GolfBallBusLogic : iEntityEditorBusinesssLogic
    {
        public object Copy(object obj)
        {
            EntityGolfBalls e = (EntityGolfBalls)obj;
            EntityGolfBalls golfBallNew = new EntityGolfBalls("Copy of " + e.ToString());
            // TODO Add obj to DB
            return golfBallNew;
        }

        public void Modify(object obj)
        {}

        public void Delete(object obj)
        {
            // TODO Remove obj from DB
        }

        public void Preview(object obj)
        { }

        public object Create()
        {
            // TODO Add obj to DB
            return new Int32();
        }
        public void Links()
        { }
        public void Import()
        { }
        public void HelpModify(object obj)
        { }
        public void HelpPreview(object obj)
        { }
        public void ChangeDisplayName(int name)
        { }


    }

}
