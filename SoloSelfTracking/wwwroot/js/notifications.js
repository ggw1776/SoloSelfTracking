var warningnotification = new Audio('../audio/545495__ienba__notification.wav')
window.notificationUtilities = {
    warning: async function (text) {
        toastr.warning(text);
        warningnotification.play();
    }
};