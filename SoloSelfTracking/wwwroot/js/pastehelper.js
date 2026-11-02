let pasteHandler = null;
let focusHandler = null;

export function attachPasteHandler(dotNetReference) {
    pasteHandler = async (event) => {
        event.preventDefault();

        const pastedText = event.clipboardData?.getData("text/plain");

        if (pastedText)
            await processPastedText(dotNetReference, pastedText);
    };

    document.addEventListener("paste", pasteHandler);
}

export function attachFocusHandler(dotNetReference) {

    focusHandler = async () => {
        try {
            const text = await navigator.clipboard.readText();

            if (text)
                await processFocusText(dotNetReference, text);
        }
        catch (error) {
            // Clipboard permissions may prevent reading on focus.
        }
    };

    window.addEventListener("focus", focusHandler);
}

async function processPastedText(dotNetReference, text) {
    const found = await dotNetReference.invokeMethodAsync(
        "HandlePastedItem",
        text
    );

    if (!found)
        toastr.error("item not found");
}

async function processFocusText(dotNetReference, text) {
    const found = await dotNetReference.invokeMethodAsync(
        "HandleFocusedItem",
        text
    );
}

export function detachPasteHandler() {
    document.removeEventListener("paste", pasteHandler);
    window.removeEventListener("focus", focusHandler);

    pasteHandler = null;
    focusHandler = null;
}