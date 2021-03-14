# Important Definitions

> #### Info::Event Handling
>
> A style of user interaction that browsers use to allow developers to react and interact with a user's use of their site.

Event handling is managed all in JavaScript and it not written into CSS or into the HTML. It is how UIs are managed on the web.

> #### Info::Event Handler
>
> A function that can be attached to a DOM element and run when a defined type of event happens on that DOM element.

The function can be an anonymous function or a named function.

> #### Info::Event Objects
>
> An object given to every Event Handler that defines properties about that event, like location, which DOM element the event happened on, and key presses or mouse click information.

Event object are always passed in as the first parameter to an Event Handler function.

> #### Info::Event Propagation
>
> The process of an event firing on a DOM element and every parent of the DOM element up to the `window` object.

You can stop propagation at a certain level by calling `event.stopPropagation()` at that DOM element.

> #### Info::Default Action
>
> The default process that a browser will perform if no Event Handler prevents it from happening.

You can stop default behavior by calling `event.preventDefault()`.

Default behavior is most important to watch out for on buttons, forms, and a elements.