using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication;

namespace TestProject
{
    internal class TaskManagerTest
    {
        private TaskManager _taskManager;
        [SetUp]
        public void Setup()
        {
            _taskManager = new TaskManager();
        }
        [Test]
        public void AddTask_ShouldIncreaseTaskCount()
        {
            // Arrange
            var task = new WebApplication.Task("Test task");
            // Act
            _taskManager.AddTask(task);
            // Assert
            Assert.AreEqual(1, _taskManager.GetTasks().Count);
        }


        [Test]
        //c
        public void MarkTaskAsCompleted_ExistingTask_ShouldMarkTaskAsCompleted()
        {
            //Arrage
            var task = new WebApplication.Task("Task c");
            //Act
            _taskManager.MarkTaskAsCompleted(20);
            //Assert
            Assert.IsTrue(!task.IsCompleted);
        }

        [Test]
        //d
        public void MarkTaskAsCompleted_NonExistingTask_ShouldNotMarkTaskAsCompleted()
        {
            //Arrage
            var task = new WebApplication.Task("Task d");
            //Act
            _taskManager.MarkTaskAsCompleted(25);
            //Assert
            Assert.That(task.IsCompleted, Is.False);
        }

        [Test]
        //a
        public void RemoveTask_ExistingTask_ShouldDecreaseTaskCount()
        {
            //Arrage
            var task = new WebApplication.Task("Task a");
            //Act
            _taskManager.RemoveTask(1);
            //Assert
            Assert.AreEqual(_taskManager.GetTasks().Count, );
        }



    }

    

}

