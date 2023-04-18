# SOLID Design Principles

## Single Responsibility Principle

A Class should have one and only one reason to change, meaning a class should have only one job.

## Open Closed Principle

A class or module should be open for extension and closed for modification

## Liskovs Substitution Principle

Let q(x) be a property provable about objects of type x, then q(y) should be provable for object y of type S where S is a subtype of T

## Interface Segregation Principle

A Clinet should never be forced to implement an interface that they dont use, or clients should not be forced to depend on methods they dont use

Many client specific interfaces are better than one general purpose one

## Dependency Inversion Principle

High level modules should not depend on low level modules, both should depend on abstractions

One should depend on abstractions, not concretions