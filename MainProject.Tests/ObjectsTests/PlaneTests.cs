using FluentAssertions;
using MainProject.Objects;
using NUnit.Framework;


namespace MainProject.Tests.ObjectsTests
{
    internal class PlaneTests
    {
        [Test]
        [Category("Negative")]
        public void GetIntersectionWith_ParallelRayTest()
        {
            var plane = new Plane(new Vector(1, 2, 0), new Point(0, 0, 0));

            var ray = new Ray
            {
                Origin = new Point(0, 0, 0),
                Direction = new Vector(-2, 1, 0)
            };

            plane.GetIntersectionWith(ray).Should().BeNull();
        }

        //[Test]
        //[Category("Negative")]
        //public void GetIntersectionWith_NoIntersectionTest()
        //{
        //    var plane = new Plane(new Vector(-1, -2, -3), new Point(0, 0, 0));


        //    var ray = new Ray
        //    {
        //        Origin = new Point(0, 0, 0),
        //        Direction = new Vector(5, 1, 0)
        //    };

        //    plane.GetIntersectionWith(ray).Should().BeNull();
        //}

        [Test]
        [Category("Positive")]
        public void GetIntersectionWith_IntersectionTest()
        {
            var plane = new Plane(new Vector(3, -1, 4), new Point(0, 0, 0));


            var ray = new Ray
            {
                Origin = new Point(0, 0, 0),
                Direction = new Vector(-2, 3, 1)
            };

            plane.GetIntersectionWith(ray).Should().NotBeNull();
        }


    }
}
