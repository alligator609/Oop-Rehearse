# Oop-Rehearse
# static method 
static method is used in a class so that we do don't have to create an object of the class in order to use the method

# ReadOnly
 it will initilize a filed only once.
 
# AccessModifier 
 A way to control access to a class and its member . To protect its internal data.Accessmodifiers are  Public,Private,Protected,Internal,Protected Internal 
Public: A member declared as public is accessible everywhere.
Private: A member declared as private is accessible only from the class.
Protected: A member declared as protected is accessibly only from the class and its derived classes. Protected breaks encapsulation (because the implementation details of a class will leak into its derived classes) and is better to be avoided.
Internal: A member declared as internal is accessibly only from the same assembly.
Protected Internal: A member declared as protected internal is accessible only fromthe same assembly or any derived classes. (Sounds weird? Forget it! It’s not really used.)
# property 
'public string Name { get; set; }'  c# automatically create private property called Name and get and set it 

# Indexer 
Indexer an easier way to access elements of an collection

# Class Coupling
 A measure of how interconnected classes and subsystems are.
 The more coupled classes, the harder it is to change them. A change in one class may affect many other classes.
 Loosely coupled software, as opposed to tightly coupled software, is easier to change.
 Two types of relationships between classes: Inheritance and Composition.


# Inheritance 

A kind of relationship between two classes that allows one to inherit code from the other.
Referred to as Is-A relationship: A Car is a Vehicle
Benefits: code re-use and polymorphic behaviour.


# Constructors and Inheritance
Constructors are not inherited and need to explicitly defined in derived class.
When creating an object of a type that is part of an inheritance hierarchy, base class constructors are always executed first.
We can use the base keyword to pass control to a base class constructor.


# Composition
A kind of relationship that allows one class to contain another.
Referred to as Has-A relationship: A Car has an Engine


# Upcasting and Downcasting
Upcasting: conversion from a derived class to a base class
Downcasting: conversion from a base class to a derived class

# Boxing and Unboxing
C# types are divided into two categories: value types and reference types.
Value types (eg int, char, bool, all primitive types and struct) are stored in the stack.
They have a short life time and as soon as they go out of scope are removed from memory.
Reference types (eg all classes) are stored in the heap.
Every object can be implicitly cast to a base class reference.
The object class is the parent of all classes in .NET Framework.
So a value type instance (eg int) can be implicitly cast to an object reference.

Boxing happens when a value type instance is converted to an object reference.
Unboxing is the opposite: when an object reference is converted to a value type.
Both boxing and unboxing come with a performance penalty. This is not noticeable when dealing with small number of objects. But if you’re dealing with several thousands or tens of thousands of objects, it’s better to avoid it.

// Boxing
object obj = 1;
// Unboxing
int i = (int)obj;