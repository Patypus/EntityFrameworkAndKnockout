ko.bindingHandlers.slidedownbinder = {
    init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        $(element).hide();
    },
    update: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        var displayValue = ko.unwrap(valueAccessor());
        
        if (displayValue) {
            $(element).slideDown();
        } else {
            $(element).slideUp();
        }
    }
}