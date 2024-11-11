import math


def is_number_prime(number: int) -> bool:
    is_prime: bool = False
    if number > 1:
        finite_number: int = int(math.sqrt(number))
        for i in range(2, finite_number + 1):
            if number % i == 0:
                break
        else:
            is_prime = True
    return is_prime


def define_n_prime_number(n: int) -> int:
    count_of_primes: int = 0
    number: int = 2
    while True:
        is_prime: bool = is_number_prime(number)
        if is_prime:
            count_of_primes += 1
        if count_of_primes == n:
            return number
        number += 1


def main() -> None:
    n: int = 10001

    if n <= 0:
        print(f"Error. The number n must be > 0.")
        return

    result: int = define_n_prime_number(n)

    print(f"The {n}th prime number is {result}.")


if __name__ == "__main__":
    main()
