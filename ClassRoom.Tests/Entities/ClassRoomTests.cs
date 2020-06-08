using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom.Domain.Enuns;

namespace ClassRoom.Tests.Entities
{
    [TestClass]
    [TestCategory("Tests ClassRoom")]
    public class ClassRoomTests
    {

        private ClassRoom.Domain.Entities.ClassRoom _invalidClassRoom;
        private ClassRoom.Domain.Entities.ClassRoom _validClassRoom;

        public ClassRoomTests()
        {
            _invalidClassRoom = new ClassRoom.Domain.Entities.ClassRoom("", EClassRoomStatus.Free, EClassRoomType.Laboratory);
            _validClassRoom = new ClassRoom.Domain.Entities.ClassRoom("ClassRoom 1", EClassRoomStatus.Free, EClassRoomType.Normal);
        }

        [TestMethod]
        public void DeveRetornarFalsoSeClassRoomInvalido()
        {
            var classRomm = new ClassRoom.Domain.Entities.ClassRoom("q", EClassRoomType.Normal, EClassRoomStatus.Reserved);
            Assert.IsFalse(classRomm.Valid);
        }

        [TestMethod]
        public void DeveRetornarFalsoSeClassRomNulo()
        {
            var classRomm = new ClassRoom.Domain.Entities.ClassRoom(null, null, null);
            Assert.IsFalse(classRomm.Valid);
        }

        [TestMethod]
        public void DeveRetornarVerdadeiroSeClassRommValido()
        {
            var classRomm = new ClassRoom.Domain.Entities.ClassRoom(, null, null);
            Assert.IsFalse(classRomm.Valid);
        }
    }
}
