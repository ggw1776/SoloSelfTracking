window.notificationUtilities = {
    warning: async function (text) {
        toastr.warning(text);
        (new Audio('../audio/545495__ienba__notification.wav')).play();
    }
};