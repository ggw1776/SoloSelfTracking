window.itemTooltip = {
    position: function (mouseX, mouseY, tooltipWidth, tooltipHeight) {
        const offset = 16;
        const margin = 8;

        let x = mouseX + offset;
        let y = mouseY + offset;

        if (x + tooltipWidth > window.innerWidth - margin) {
            x = mouseX - tooltipWidth - offset;
        }

        if (y + tooltipHeight > window.innerHeight - margin) {
            y = mouseY - tooltipHeight - offset;
        }

        x = Math.max(margin, Math.min(x, window.innerWidth - tooltipWidth));
        y = Math.max(margin, Math.min(y, window.innerHeight - tooltipHeight - margin));
        return { x, y };
    }
};