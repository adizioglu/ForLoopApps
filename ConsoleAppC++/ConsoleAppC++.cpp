#include <iostream>
#include <vector>

int main() {
    // for (int i = 0; i < 10; i++) {
    //     std::cout << "The value of i is " << i << std::endl;
    // }

    // std::string data = "Tim,Sue,Bob,Jane";
    // std::vector<std::string> firstNames;
    // std::stringstream ss(data);
    // std::string name;
    // while (std::getline(ss, name, ',')) {
    //     firstNames.push_back(name);
    // }

    // for (size_t i = 0; i < firstNames.size(); i++) {
    //     std::cout << firstNames[i] << " is in attendance" << std::endl;
    // }

    std::vector<double> charges;

    charges.push_back(23.78);
    charges.push_back(15.89);
    charges.push_back(125.0);

    double total = 0;

    for (size_t i = 0; i < charges.size(); i++) {
        total += charges[i];
    }

    std::cout << "Our total charge is " << total << std::endl;

    return 0;
}
