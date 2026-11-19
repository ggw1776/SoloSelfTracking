let pasteHandler = null;

export function attachPasteHandler(dotNetReference) {
    pasteHandler = async (event) => {

        if (event.target.closest?.("[data-allow-native-paste]")) {
            return;
        }


        event.preventDefault();

        const pastedText = event.clipboardData?.getData("text/plain");

        if (pastedText)
            await processPastedText(dotNetReference, pastedText);
    };

    document.addEventListener("paste", pasteHandler);
}

async function processPastedText(dotNetReference, text) {
    const found = await dotNetReference.invokeMethodAsync(
        "HandlePastedItem",
        text
    );

    if (!found)
        toastr.error("item not found");
}


export function detachPasteHandler() {
    document.removeEventListener("paste", pasteHandler);

    pasteHandler = null;
}

window.clipboardUtilities = {
    clear: async function () {
        try {
            await navigator.clipboard.writeText("Cleared by SoloSelfTracking");
            return true;
        }
        catch (error) {
            console.error("Failed to clear clipboard:", error);
            return false;
        }
    }
};