using Aqua;
using NUnit.Framework;
using System;

namespace AquaProject.Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FishConstructorShouldInicializeCorrectly()
        {
            Fish fish = new Fish("golden", 3);
            Assert.AreEqual("golden", fish.Type);
            Assert.AreEqual(3, fish.Price);
        }

        [Test]
        public void AquariumConstructorShouldInicializeCorrectly()
        {
            Aquarium aquarium = new Aquarium("circle", 100);
            Assert.AreEqual("circle", aquarium.Shape);
            Assert.AreEqual(100, aquarium.Capacity);
        }

        [Test]
        public void AddMethodShoudReduceAquariumCapacity()
        {
            Aquarium aquarium = new Aquarium("circle", 100);
            Fish fish = new Fish("golden", 3);
            aquarium.AddFish(fish);
            Assert.AreEqual(99, aquarium.Capacity);
        }

        [Test]
        public void AddMethodShoudAddFish()
        {
            Aquarium aquarium = new Aquarium("circle", 100);
            Fish fish = new Fish("golden", 3);
            aquarium.AddFish(fish);
            Assert.AreEqual(1, aquarium.Fishes.Count);
        }

        [Test]
        public void AddMethodShoudAddExactliOneFish()
        {
            Aquarium aquarium = new Aquarium("circle", 100);
            Fish fish = new Fish("golden", 3);
            aquarium.AddFish(fish);
            Assert.AreEqual(1, aquarium.Fishes.Count);
        }
        [Test]
        public void AddMethodShoudThrowInvalidOperationException()
        {
            Aquarium aquarium = new Aquarium("circle", 0);
            Fish fish = new Fish("golden", 3);
            Assert.Throws<InvalidOperationException>(() => aquarium.AddFish(fish));
        }
        [Test]
        public void AddMethodShoudThrowExactMessageException()
        {
            Aquarium aquarium = new Aquarium("circle", 0);
            Fish fish = new Fish("golden", 3);
            var ex = Assert.Throws<InvalidOperationException>(() => aquarium.AddFish(fish));
            Assert.AreEqual("Invalid operation", ex.Message);
        }
        [Test]
        public void ReportAddFishShoudPrintExactSuccessfulMessage()
        {
            Aquarium aquarium = new Aquarium("circle", 100);
            Fish fish = new Fish("golden", 3);
            Assert.AreEqual("You successfully add a fish!", aquarium.ReportAddFish());
        }

        [Test]
        public void EmptyMethodShoudWorkCorrectly()
        {
            Aquarium aquarium = new Aquarium("circle", 100);
            Fish fish = new Fish("golden", 3);
            aquarium.AddFish(fish);
            aquarium.Empty();
            Assert.AreEqual(100, aquarium.Capacity);
            Assert.AreEqual(0, aquarium.Fishes.Count);
        }
        [Test]
        public void EmptyMethodShoudThrowEx()
        {
            Aquarium aquarium = new Aquarium("circle", 0);
            Fish fish = new Fish("golden", 3);
            Assert.Throws<InvalidOperationException>(() => aquarium.Empty());
        }
        [Test]
        public void EmptyMethodShoudThrowExactEx()
        {
            Aquarium aquarium = new Aquarium("circle", 0);
            Fish fish = new Fish("golden", 3);
            var ex = Assert.Throws<InvalidOperationException>(() => aquarium.Empty());
            Assert.AreEqual("Aquarium is empty!", ex.Message);
        }
    }
}