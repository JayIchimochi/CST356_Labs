using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;

public class StudentServiceTests
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock
    private bool IsSpecial(long id){
        if (id % 5 == 0){
            return true;
        }
        return false;
    }

    [SetUp]
    public void Setup()
    {
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void NoneShouldBeSpecial()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = "4",
                    Email = "user1@domain.com"
                },
                new Student {
                    StudentId = "7",
                    Email = "user2@domain.com"
                }
            }
        );

        // Act (When)
        var StudentViewModels = _StudentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(StudentViewModels.Any(pdto => pdto.IsSpecial), Is.EqualTo(false));

        // Assert (FluentAssertions) (Then)
        StudentViewModels.Any(pdto => pdto.IsSpecial).Should().BeFalse();
    }

    [Test]
    public void AnyShouldBeSpecial()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = "5",
                    Email = "user1@domain.com"
                },
                new Student {
                    StudentId = "7",
                    Email = "user2@domain.com"
                }
            }
        );

        // Act (When)
        var StudentViewModels = _StudentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(StudentViewModels.Any(pdto => pdto.IsSpecial), Is.EqualTo(true));

        // Assert (FluentAssertions) (Then)
        StudentViewModels.Any(pdto => pdto.IsSpecial).Should().BeTrue();
    }

    [Test]
    public void AllShouldBeSpecial()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = "5",
                    Email = "user1@domain.com"
                },
                new Student {
                    StudentId = "10",
                    Email = "user2@domain.com"
                }
            }
        );

        // Act (When)
        var StudentViewModels = _StudentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(StudentViewModels.All(pdto => pdto.IsSpecial), Is.EqualTo(True));

        // Assert (FluentAssertions) (Then)
        StudentViewModels.All(pdto => pdto.IsSpecial).Should().BeTrue();
    }
}