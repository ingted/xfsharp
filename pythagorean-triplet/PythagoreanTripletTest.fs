module PythagoreanTripletTest

open PythagoreanTriplet
open NUnit.Framework

[<TestFixture>]
type PythagoreanTripletTest() =

    [<Test>]
    member test.``Calculates the sum``() =
        Assert.That(PythagoreanTriplet(3.0, 4.0, 5.0).Sum(), Is.EqualTo(12))

    [<Test>]
    member test.``Calculates the product``() =
        Assert.That(PythagoreanTriplet(3.0, 4.0, 5.0).Product(), Is.EqualTo(60))

    [<Test>]
    member test.``Can recognize a valid pythagorean``() = 
        Assert.IsTrue(PythagoreanTriplet(3.0, 4.0, 5.0).IsPythagorean())

    [<Test>]
    member test.``Can recognize a valid pythagorean 2``() = 
        Assert.IsFalse(PythagoreanTriplet(5.0, 6.0, 7.0).IsPythagorean())