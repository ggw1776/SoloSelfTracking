var warningnotification = new Audio('../audio/545495__ienba__notification.wav')
var calmingnotification = new Audio('../audio/511437__theojt__relaxing-short-music.mp3')
window.notificationUtilities = {
    warning: async function (text) {
        toastr.warning(text);
        warningnotification.play();
    },
    calm: async function () {
        calmingnotification.play();
    }
};