def count_recurring_cycle_length(n: int, d: int) -> int:
    for i in range(1, d):
        if n == 10 ** i % d:
            return i
    return 0


def count_longest_recurring_cycle(n: int) -> int:
    start_number = 2

    max_length = 0
    d = start_number

    for i in range(start_number, n):

        if i % 5 == 0:
            continue

        length: int = count_recurring_cycle_length(1, i)

        if length > max_length:
            max_length = length
            d = i

    return d


def main() -> None:
    number: int = 1000
    result: int = count_longest_recurring_cycle(number)
    print(f"Result value d={result} for d<{number}.")


if __name__ == "__main__":
    main()
