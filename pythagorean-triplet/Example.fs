module PythagoreanTriplet

type PythagoreanTriplet(a, b, c) =
    member x.Sum() = a + b + c

    member x.Product() = a * b * c

    member x.IsPythagorean() = a ** 2.0 + b ** 2.0 = c ** 2.0

    //member x.Where() =
        