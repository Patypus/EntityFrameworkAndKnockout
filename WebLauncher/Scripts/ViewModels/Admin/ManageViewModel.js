var manageViewModel = function (data) {
    var self = this;

    self.createableYears = ko.observableArray(data.YearsWithNoCreatedSeasons);
    self.editableYears = ko.observableArray(data.EditableSeasons);

    self.addYear = function () {
        debugger;
    }

    self.editYear = function () {
        debugger;
    }

    self.viewYear = function () {
        debugger;
    }
};