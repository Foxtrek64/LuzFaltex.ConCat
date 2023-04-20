# LuzFaltex.ConCat.API.Abstractions

This package contains a complete set of type and API abstractions for the ConCat API. It provides no concrete implementations; rather, it acts as a general, library-agnostic standard definition of ConCat's API.

These types serve as the foundation of LuzFaltex.ConCat's entire API surface, but can just as easily be used to implement your own ConCat library, independently of LuzFaltex.ConCat.

The primary goal of this project is to model ConCat's API as closely as possible, while at the same time applying appropriate C# practices and builtin types (such as `DateTimeOffset`).

## Structure

This library is divided into type categories, organized to match ConCat's API documentation as closely as is realistic. Each object defined by ConCat has a corresponding interface, with inline documentation that matches ConCat's.

The REST API surface is similarly divided by purpose, wherein related endpoints are grouped together (application, audit log, etc.).

## Usage

No particular usage recommendations exist for this library.