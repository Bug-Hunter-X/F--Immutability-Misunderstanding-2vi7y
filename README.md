# F# Immutability Gotcha

This example demonstrates a common pitfall for F# programmers coming from languages with mutable variables. In F#, values are immutable by default. The `addOne` function calculates a new value, but it doesn't change the value of `x` itself.